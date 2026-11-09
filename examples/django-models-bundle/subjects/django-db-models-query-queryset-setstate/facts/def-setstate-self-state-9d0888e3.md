# Fact 9d0888e3

Store id: 71875d9a-5f97-4552-b43c-8e85b33f63fc

## Text

```text
def __setstate__(self, state)
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
- posted_at: `2026-11-09T22:39:49.3107630+00:00`

## Data

```json
{
  "end_line": 446,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 429,
  "symbol": "QuerySet.__setstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":429,"selector":"L429-L446","symbol":"QuerySet.__setstate__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__setstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 446,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 429,
    "symbol": "QuerySet.__setstate__"
  },
  "id": "71875d9a-5f97-4552-b43c-8e85b33f63fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3107630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 429,
        "selector": "L429-L446",
        "symbol": "QuerySet.__setstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fbc45302-12ab-4a0e-8c19-34625c30dc6c",
  "subject_name": "django/db/models/query::QuerySet.__setstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __setstate__(self, state)"
}
```
