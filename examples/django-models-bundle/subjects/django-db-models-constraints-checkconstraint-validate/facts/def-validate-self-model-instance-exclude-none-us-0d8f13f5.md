# Fact 0d8f13f5

Store id: 80b5574d-bbb0-4f04-8b55-334fd98b9a48

## Text

```text
def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)
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
- posted_at: `2026-11-09T23:31:54.1947820+00:00`

## Data

```json
{
  "end_line": 224,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 212,
  "symbol": "CheckConstraint.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L224","symbol":"CheckConstraint.validate"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 224,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 212,
    "symbol": "CheckConstraint.validate"
  },
  "id": "80b5574d-bbb0-4f04-8b55-334fd98b9a48",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1947820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L224",
        "symbol": "CheckConstraint.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "758c36ef-95c8-4fa0-abb8-dedbdcbf3725",
  "subject_name": "django/db/models/constraints::CheckConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
