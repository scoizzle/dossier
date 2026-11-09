# Fact 752789ec

Store id: c9b9e39f-a7f1-4759-adeb-f290ebb94c9b

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:32:04.3186040+00:00`

## Data

```json
{
  "end_line": 427,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 424,
  "symbol": "QuerySet.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":424,"selector":"L424-L427","symbol":"QuerySet.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 427,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 424,
    "symbol": "QuerySet.__getstate__"
  },
  "id": "c9b9e39f-a7f1-4759-adeb-f290ebb94c9b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3186040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 424,
        "selector": "L424-L427",
        "symbol": "QuerySet.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "30f9a38e-4fd9-484f-955d-ed79ddfbbcdc",
  "subject_name": "django/db/models/query::QuerySet.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
