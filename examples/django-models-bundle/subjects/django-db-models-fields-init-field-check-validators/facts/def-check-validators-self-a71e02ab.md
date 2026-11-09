# Fact a71e02ab

Store id: c9b7d8e1-40f3-4d18-8fa9-3e9d2b5b3d1c

## Text

```text
def _check_validators(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9826910+00:00`

## Data

```json
{
  "end_line": 545,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 527,
  "symbol": "Field._check_validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":527,"selector":"L527-L545","symbol":"Field._check_validators"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 545,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 527,
    "symbol": "Field._check_validators"
  },
  "id": "c9b7d8e1-40f3-4d18-8fa9-3e9d2b5b3d1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9826910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 527,
        "selector": "L527-L545",
        "symbol": "Field._check_validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8d9972f3-58bd-4ef7-8d43-4149a83e1c0a",
  "subject_name": "django/db/models/fields/__init__::Field._check_validators",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_validators(self)"
}
```
