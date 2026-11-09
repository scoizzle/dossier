# Fact 9d0888e3

Store id: a64a58a5-2a93-458d-b94d-274b97d00ae1

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
- posted_at: `2026-11-09T23:44:55.8431440+00:00`

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
  "id": "a64a58a5-2a93-458d-b94d-274b97d00ae1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8431440+00:00"
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
  "subject_id": "f6c44fef-8eab-418a-8f4d-af990b387673",
  "subject_name": "django/db/models/query::QuerySet.__setstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __setstate__(self, state)"
}
```
