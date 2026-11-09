# Fact a3c3c021

Store id: a1faedc0-21b0-4e8a-87ad-ae8632893049

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T22:39:42.0045680+00:00`

## Data

```json
{
  "end_line": 43,
  "entity_kind": "method",
  "parent": "FetchPeers",
  "start_line": 42,
  "symbol": "FetchPeers.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L43","symbol":"FetchPeers.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchPeers.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 43,
    "entity_kind": "method",
    "parent": "FetchPeers",
    "start_line": 42,
    "symbol": "FetchPeers.__reduce__"
  },
  "id": "a1faedc0-21b0-4e8a-87ad-ae8632893049",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.0045680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L43",
        "symbol": "FetchPeers.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "3cf25b1c-5a5a-4ce4-b63b-a65247e1f85f",
  "subject_name": "django/db/models/fetch_modes::FetchPeers.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
