# Fact e72e6473

Store id: 117b1c9c-7ce9-41f8-ab80-d3afda150c68

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:47.8064610+00:00`

## Data

```json
{
  "end_line": 299,
  "entity_kind": "method",
  "parent": "Index",
  "start_line": 285,
  "symbol": "Index.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":285,"selector":"L285-L299","symbol":"Index.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 299,
    "entity_kind": "method",
    "parent": "Index",
    "start_line": 285,
    "symbol": "Index.__repr__"
  },
  "id": "117b1c9c-7ce9-41f8-ab80-d3afda150c68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.8064610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 285,
        "selector": "L285-L299",
        "symbol": "Index.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "9a398283-0b29-4c92-8b50-84d5f2a49354",
  "subject_name": "django/db/models/indexes::Index.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
