# Fact 5caf4641

Store id: 7025d889-6920-49f9-b8c1-7d3b6529c79b

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
- posted_at: `2026-11-09T22:39:41.9952050+00:00`

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
  "id": "7025d889-6920-49f9-b8c1-7d3b6529c79b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.9952050+00:00"
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
  "subject_id": "af590b7a-da4b-41f2-9a65-cb665a0c4d34",
  "subject_name": "django/db/models/fetch_modes::FetchOne.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
