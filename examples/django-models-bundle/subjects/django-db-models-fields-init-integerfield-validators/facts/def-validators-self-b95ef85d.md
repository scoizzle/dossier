# Fact b95ef85d

Store id: 009eb287-a812-492f-b0f5-f464f176726f

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
- posted_at: `2026-11-09T23:31:56.6969010+00:00`

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
  "id": "009eb287-a812-492f-b0f5-f464f176726f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6969010+00:00"
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
  "subject_id": "d849af8c-6f14-4603-84d5-7d47a713867b",
  "subject_name": "django/db/models/fields/__init__::IntegerField.validators",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def validators(self)"
}
```
