# Fact 94e7c401

Store id: 70d0b5e8-6bc6-4f65-bbcd-509ab8b0e618

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
- posted_at: `2026-11-09T23:31:54.3277230+00:00`

## Data

```json
{
  "end_line": 686,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 578,
  "symbol": "UniqueConstraint.validate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":578,"selector":"L578-L686","symbol":"UniqueConstraint.validate"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.validate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 686,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 578,
    "symbol": "UniqueConstraint.validate"
  },
  "id": "70d0b5e8-6bc6-4f65-bbcd-509ab8b0e618",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.3277230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 578,
        "selector": "L578-L686",
        "symbol": "UniqueConstraint.validate"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "06e19da9-869f-4235-ace1-62b4692c59f0",
  "subject_name": "django/db/models/constraints::UniqueConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
