# Fact 4d155bbc

Store id: b427c146-0572-4db0-b01f-790ea3af14b5

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
- posted_at: `2026-11-09T22:39:42.0137650+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "FetchRaise",
  "start_line": 57,
  "symbol": "FetchRaise.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fetch_modes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":57,"selector":"L57-L58","symbol":"FetchRaise.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/fetch_modes::FetchRaise.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "FetchRaise",
    "start_line": 57,
    "symbol": "FetchRaise.__reduce__"
  },
  "id": "b427c146-0572-4db0-b01f-790ea3af14b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.0137650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 57,
        "selector": "L57-L58",
        "symbol": "FetchRaise.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fetch_modes.py"
    }
  ],
  "status": "live",
  "subject_id": "ef1e2124-2c30-4322-9407-29cdb15fad6b",
  "subject_name": "django/db/models/fetch_modes::FetchRaise.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
