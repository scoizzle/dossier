# Fact 12a8643c

Store id: 631354d6-bb98-44e3-bca4-9fb1d043f624

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
- posted_at: `2026-11-09T22:39:41.7953050+00:00`

## Data

```json
{
  "end_line": 2235,
  "entity_kind": "method",
  "parent": "ValueRange",
  "start_line": 2234,
  "symbol": "ValueRange.window_frame_start_end"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2234,"selector":"L2234-L2235","symbol":"ValueRange.window_frame_start_end"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ValueRange.window_frame_start_end](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2235,
    "entity_kind": "method",
    "parent": "ValueRange",
    "start_line": 2234,
    "symbol": "ValueRange.window_frame_start_end"
  },
  "id": "631354d6-bb98-44e3-bca4-9fb1d043f624",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7953050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2234,
        "selector": "L2234-L2235",
        "symbol": "ValueRange.window_frame_start_end"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ad6737a4-de4d-4712-9e53-085c4f478c4d",
  "subject_name": "django/db/models/expressions::ValueRange.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
