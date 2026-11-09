# Fact 370b6037

Store id: a6b2d6b7-5dfc-42f3-9c52-bbd6c37d2450

## Text

```text
def __and__(self, other)
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
- posted_at: `2026-11-09T23:44:55.8682160+00:00`

## Data

```json
{
  "end_line": 540,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 530,
  "symbol": "QuerySet.__and__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":530,"selector":"L530-L540","symbol":"QuerySet.__and__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__and__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 540,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 530,
    "symbol": "QuerySet.__and__"
  },
  "id": "a6b2d6b7-5dfc-42f3-9c52-bbd6c37d2450",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8682160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 530,
        "selector": "L530-L540",
        "symbol": "QuerySet.__and__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "45b53e39-36fb-4d79-a7b5-14ed9ae8e573",
  "subject_name": "django/db/models/query::QuerySet.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
