# Fact 27a59fe4

Store id: a8a6d76d-2f59-484e-a117-79232aab079d

## Text

```text
def window_frame_start_end(self, connection, start, end)
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
- posted_at: `2026-11-09T22:39:41.7928500+00:00`

## Data

```json
{
  "end_line": 2228,
  "entity_kind": "method",
  "parent": "RowRange",
  "start_line": 2227,
  "symbol": "RowRange.window_frame_start_end"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2227,"selector":"L2227-L2228","symbol":"RowRange.window_frame_start_end"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RowRange.window_frame_start_end](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2228,
    "entity_kind": "method",
    "parent": "RowRange",
    "start_line": 2227,
    "symbol": "RowRange.window_frame_start_end"
  },
  "id": "a8a6d76d-2f59-484e-a117-79232aab079d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7928500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2227,
        "selector": "L2227-L2228",
        "symbol": "RowRange.window_frame_start_end"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "effb0ca2-9d7b-4b55-9806-6e9133848a78",
  "subject_name": "django/db/models/expressions::RowRange.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
