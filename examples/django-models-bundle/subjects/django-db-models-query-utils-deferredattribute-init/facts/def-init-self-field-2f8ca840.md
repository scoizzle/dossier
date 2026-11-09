# Fact 2f8ca840

Store id: f7709f53-cfaa-4644-9868-49f0adf3e226

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
- posted_at: `2026-11-09T23:32:05.1080190+00:00`

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
  "id": "f7709f53-cfaa-4644-9868-49f0adf3e226",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1080190+00:00"
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
  "subject_id": "e581c108-4f1a-4a44-857a-f8c4020265be",
  "subject_name": "django/db/models/query_utils::DeferredAttribute.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field)"
}
```
