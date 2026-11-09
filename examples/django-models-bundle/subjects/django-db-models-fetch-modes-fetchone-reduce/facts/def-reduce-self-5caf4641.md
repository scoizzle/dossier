# Fact 5caf4641

Store id: b1313fdf-e24c-43e2-b2a3-079186e4e49e

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
- posted_at: `2026-11-09T23:31:56.2191370+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "method",
  "parent": "FetchOne",
  "start_line": 19,
  "symbol": "FetchOne.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L20","symbol":"FetchOne.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchOne.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "method",
    "parent": "FetchOne",
    "start_line": 19,
    "symbol": "FetchOne.__reduce__"
  },
  "id": "b1313fdf-e24c-43e2-b2a3-079186e4e49e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2191370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L20",
        "symbol": "FetchOne.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "21961650-1281-45b4-b798-62f8d32bb1fc",
  "subject_name": "django/db/models/fetch_modes::FetchOne.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
