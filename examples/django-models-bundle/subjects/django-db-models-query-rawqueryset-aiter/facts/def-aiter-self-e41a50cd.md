# Fact e41a50cd

Store id: 628b7753-12d4-4a0e-9ed1-3e56c08a604d

## Text

```text
def __aiter__(self)
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
- posted_at: `2026-11-09T23:32:04.7456280+00:00`

## Data

```json
{
  "end_line": 2511,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2503,
  "symbol": "RawQuerySet.__aiter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2503,"selector":"L2503-L2511","symbol":"RawQuerySet.__aiter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__aiter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2511,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2503,
    "symbol": "RawQuerySet.__aiter__"
  },
  "id": "628b7753-12d4-4a0e-9ed1-3e56c08a604d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7456280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2503,
        "selector": "L2503-L2511",
        "symbol": "RawQuerySet.__aiter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fb1ae90d-79a6-44c1-9ae8-4b369377ebef",
  "subject_name": "django/db/models/query::RawQuerySet.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
