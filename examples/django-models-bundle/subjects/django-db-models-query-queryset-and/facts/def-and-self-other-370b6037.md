# Fact 370b6037

Store id: f97da3de-598b-4b8d-9efe-582bb9e1507d

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
- posted_at: `2026-11-09T22:39:49.3477280+00:00`

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
  "id": "f97da3de-598b-4b8d-9efe-582bb9e1507d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3477280+00:00"
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
  "subject_id": "ae5882ab-dd1c-439b-bfb0-529c5f31fd3a",
  "subject_name": "django/db/models/query::QuerySet.__and__",
  "tags": [
    "entity:method"
  ],
  "text": "def __and__(self, other)"
}
```
