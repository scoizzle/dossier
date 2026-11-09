# Fact b95ef85d

Store id: 8fd8015d-ead8-4db0-8358-28c5198bcdd0

## Text

```text
def validators(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1622890+00:00`

## Data

```json
{
  "end_line": 2200,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2167,
  "symbol": "IntegerField.validators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2167,"selector":"L2167-L2200","symbol":"IntegerField.validators"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.validators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2200,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2167,
    "symbol": "IntegerField.validators"
  },
  "id": "8fd8015d-ead8-4db0-8358-28c5198bcdd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1622890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2167,
        "selector": "L2167-L2200",
        "symbol": "IntegerField.validators"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "f9cd0f4e-b250-48e3-80b0-f5b79279c4b6",
  "subject_name": "django/db/models/fields/__init__::IntegerField.validators",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def validators(self)"
}
```
