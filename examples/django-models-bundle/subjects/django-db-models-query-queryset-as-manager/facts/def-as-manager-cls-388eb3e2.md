# Fact 388eb3e2

Store id: 5bc04f42-06e6-4894-a7ac-a44c560d358d

## Text

```text
def as_manager(cls)
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
- posted_at: `2026-11-09T23:44:55.8348910+00:00`

## Data

```json
{
  "end_line": 405,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 399,
  "symbol": "QuerySet.as_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":399,"selector":"L399-L405","symbol":"QuerySet.as_manager"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.as_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 405,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 399,
    "symbol": "QuerySet.as_manager"
  },
  "id": "5bc04f42-06e6-4894-a7ac-a44c560d358d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8348910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 399,
        "selector": "L399-L405",
        "symbol": "QuerySet.as_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "682289f0-92cb-44d5-b89e-2c3711ed2da3",
  "subject_name": "django/db/models/query::QuerySet.as_manager",
  "tags": [
    "entity:method"
  ],
  "text": "def as_manager(cls)"
}
```
