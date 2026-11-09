# Fact 2f8ca840

Store id: b9bb7a79-29b3-424d-b820-ce3aedfa854b

## Text

```text
def __init__(self, field)
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
- posted_at: `2026-11-09T22:39:50.1126210+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "method",
  "parent": "DeferredAttribute",
  "start_line": 256,
  "symbol": "DeferredAttribute.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":256,"selector":"L256-L257","symbol":"DeferredAttribute.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::DeferredAttribute.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "method",
    "parent": "DeferredAttribute",
    "start_line": 256,
    "symbol": "DeferredAttribute.__init__"
  },
  "id": "b9bb7a79-29b3-424d-b820-ce3aedfa854b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1126210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 256,
        "selector": "L256-L257",
        "symbol": "DeferredAttribute.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "33765deb-c61e-47ce-b53e-56c9ed00295e",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field)"
}
```
