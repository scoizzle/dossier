# Fact a71e02ab

Store id: 48b24097-7e64-4338-b147-93a7430b6e83

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
- posted_at: `2026-11-09T22:39:42.2864940+00:00`

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
  "id": "48b24097-7e64-4338-b147-93a7430b6e83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2864940+00:00"
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
  "subject_id": "2cbca365-a37f-4e8f-96c2-f58376f6b8e2",
  "subject_name": "django/db/models/fields/__init__::Field._check_validators",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_validators(self)"
}
```
