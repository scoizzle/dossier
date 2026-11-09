# Fact e41a50cd

Store id: fae523f5-e337-4876-977e-5b0f144bdd9a

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
- posted_at: `2026-11-09T22:39:49.8035390+00:00`

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
  "id": "fae523f5-e337-4876-977e-5b0f144bdd9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8035390+00:00"
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
  "subject_id": "8490419e-32d2-44b6-8d88-b77008f0354b",
  "subject_name": "django/db/models/query::RawQuerySet.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
