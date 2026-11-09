# Fact 12a8643c

Store id: 55251a6d-8dd9-43ea-bbba-9b545d70c207

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
- posted_at: `2026-11-09T23:31:56.0441740+00:00`

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
  "id": "55251a6d-8dd9-43ea-bbba-9b545d70c207",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0441740+00:00"
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
  "subject_id": "58d84a31-c73b-47b3-8410-ac12b675c56d",
  "subject_name": "django/db/models/expressions::ValueRange.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
