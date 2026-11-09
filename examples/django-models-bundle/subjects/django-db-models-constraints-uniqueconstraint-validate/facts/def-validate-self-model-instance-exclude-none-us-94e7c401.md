# Fact 94e7c401

Store id: 892da4b1-5f33-49d6-ba1d-2b0b72a214f0

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
- posted_at: `2026-11-09T22:39:40.7313210+00:00`

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
  "id": "892da4b1-5f33-49d6-ba1d-2b0b72a214f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7313210+00:00"
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
  "subject_id": "60ad6f80-5057-4b77-8b56-0f52d326c88d",
  "subject_name": "django/db/models/constraints::UniqueConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
