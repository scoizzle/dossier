# Fact 235b5b50

Store id: 2aef07dd-8e20-4f0a-98a4-e589336dd33b

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T22:39:49.3537550+00:00`

## Data

```json
{
  "end_line": 578,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 561,
  "symbol": "QuerySet.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":561,"selector":"L561-L578","symbol":"QuerySet.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 578,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 561,
    "symbol": "QuerySet.__xor__"
  },
  "id": "2aef07dd-8e20-4f0a-98a4-e589336dd33b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3537550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 561,
        "selector": "L561-L578",
        "symbol": "QuerySet.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "870c135f-ba3d-4b2c-a14a-975a82140d07",
  "subject_name": "django/db/models/query::QuerySet.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
