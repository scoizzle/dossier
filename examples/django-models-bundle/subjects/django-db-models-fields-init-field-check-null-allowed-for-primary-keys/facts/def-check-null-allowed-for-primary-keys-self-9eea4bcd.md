# Fact 9eea4bcd

Store id: 61852acc-1341-4148-be8b-58b5b5ff50c2

## Text

```text
def _check_null_allowed_for_primary_keys(self)
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
- posted_at: `2026-11-09T23:31:56.4348170+00:00`

## Data

```json
{
  "end_line": 516,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 495,
  "symbol": "Field._check_null_allowed_for_primary_keys"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":495,"selector":"L495-L516","symbol":"Field._check_null_allowed_for_primary_keys"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_null_allowed_for_primary_keys](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 516,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 495,
    "symbol": "Field._check_null_allowed_for_primary_keys"
  },
  "id": "61852acc-1341-4148-be8b-58b5b5ff50c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4348170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 495,
        "selector": "L495-L516",
        "symbol": "Field._check_null_allowed_for_primary_keys"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ebbf8ded-e3ca-44ef-ae88-8256fdda2d0e",
  "subject_name": "django/db/models/fields/__init__::Field._check_null_allowed_for_primary_keys",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_null_allowed_for_primary_keys(self)"
}
```
