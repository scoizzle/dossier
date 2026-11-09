# Fact dd223d21

Store id: d9146843-26be-41a1-a06c-c4e0a2baab53

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
- posted_at: `2026-11-09T23:32:04.2338840+00:00`

## Data

```json
{
  "end_line": 118,
  "entity_kind": "method",
  "parent": "BaseIterable",
  "start_line": 117,
  "symbol": "BaseIterable.__aiter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L118","symbol":"BaseIterable.__aiter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable.__aiter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 118,
    "entity_kind": "method",
    "parent": "BaseIterable",
    "start_line": 117,
    "symbol": "BaseIterable.__aiter__"
  },
  "id": "d9146843-26be-41a1-a06c-c4e0a2baab53",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2338840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L118",
        "symbol": "BaseIterable.__aiter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "14fa2de7-b188-4939-a658-d0f6cb0470d2",
  "subject_name": "django/db/models/query::BaseIterable.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
