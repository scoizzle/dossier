# Fact 27a59fe4

Store id: 99c3ef68-de55-4208-a801-244ac8639a86

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
- posted_at: `2026-11-09T23:44:49.6943950+00:00`

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
  "id": "99c3ef68-de55-4208-a801-244ac8639a86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6943950+00:00"
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
  "subject_id": "dc895169-17ad-49fb-9fca-975bb99492a4",
  "subject_name": "django/db/models/expressions::RowRange.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
