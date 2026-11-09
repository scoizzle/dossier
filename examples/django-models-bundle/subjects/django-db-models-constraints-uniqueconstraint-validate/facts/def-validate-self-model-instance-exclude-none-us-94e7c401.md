# Fact 94e7c401

Store id: a543beb3-66f7-4799-9c50-6566cd323bb6

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
- posted_at: `2026-11-09T23:44:48.7908880+00:00`

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
  "id": "a543beb3-66f7-4799-9c50-6566cd323bb6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7908880+00:00"
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
  "subject_id": "d0aaf668-3877-4712-91f3-e5c012b315a0",
  "subject_name": "django/db/models/constraints::UniqueConstraint.validate",
  "tags": [
    "entity:method"
  ],
  "text": "def validate(self, model, instance, exclude=None, using=DEFAULT_DB_ALIAS)"
}
```
