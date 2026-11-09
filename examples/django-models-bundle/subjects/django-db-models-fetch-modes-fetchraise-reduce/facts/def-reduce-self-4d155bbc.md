# Fact 4d155bbc

Store id: 46df3854-1770-49b0-80de-b26bf6f5fca7

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
- posted_at: `2026-11-09T23:31:56.2301620+00:00`

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
  "id": "46df3854-1770-49b0-80de-b26bf6f5fca7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.2301620+00:00"
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
  "subject_id": "5c2514d3-0ca6-4990-b031-85e23800d6e1",
  "subject_name": "django/db/models/fetch_modes::FetchRaise.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
