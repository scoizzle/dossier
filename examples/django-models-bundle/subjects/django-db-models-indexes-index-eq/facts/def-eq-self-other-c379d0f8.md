# Fact c379d0f8

Store id: 537cbade-7ae4-4b94-90d8-7249d8198c16

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:47.8090770+00:00`

## Data

```json
{
  "end_line": 304,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 301,
  "symbol": "Index.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":301,"selector":"L301-L304","symbol":"Index.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 304,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 301,
    "symbol": "Index.__eq__"
  },
  "id": "537cbade-7ae4-4b94-90d8-7249d8198c16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.8090770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 301,
        "selector": "L301-L304",
        "symbol": "Index.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "ef8bab63-c05c-4929-8d8c-8f362b720d2e",
  "subject_name": "django/db/models/indexes::Index.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
