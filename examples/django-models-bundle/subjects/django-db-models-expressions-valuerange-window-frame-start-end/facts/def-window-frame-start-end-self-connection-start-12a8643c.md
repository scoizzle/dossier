# Fact 12a8643c

Store id: 6d6f4d95-2a4c-46b6-b40f-0da5bb95dd69

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
- posted_at: `2026-11-09T23:44:49.6968120+00:00`

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
  "id": "6d6f4d95-2a4c-46b6-b40f-0da5bb95dd69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6968120+00:00"
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
  "subject_id": "d50f8d29-0137-4944-8df4-3adfa3630718",
  "subject_name": "django/db/models/expressions::ValueRange.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
