# Fact 5caf4641

Store id: c96a6815-3273-40aa-8bd2-1f66120a5c0b

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
- posted_at: `2026-11-09T23:44:49.8137520+00:00`

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
  "id": "c96a6815-3273-40aa-8bd2-1f66120a5c0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.8137520+00:00"
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
  "subject_id": "9317a586-386a-4ce1-95fe-5b244950270f",
  "subject_name": "django/db/models/fetch_modes::FetchOne.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
