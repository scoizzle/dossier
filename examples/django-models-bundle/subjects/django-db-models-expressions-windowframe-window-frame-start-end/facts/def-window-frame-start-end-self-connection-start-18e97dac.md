# Fact 18e97dac

Store id: 34a92458-641f-4c80-993e-0e95b899aeae

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
- posted_at: `2026-11-09T23:44:49.6912470+00:00`

## Data

```json
{
  "end_line": 2221,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2220,
  "symbol": "WindowFrame.window_frame_start_end"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2221","symbol":"WindowFrame.window_frame_start_end"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.window_frame_start_end](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2221,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2220,
    "symbol": "WindowFrame.window_frame_start_end"
  },
  "id": "34a92458-641f-4c80-993e-0e95b899aeae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6912470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2221",
        "symbol": "WindowFrame.window_frame_start_end"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ad991833-eb57-458a-9157-0c9b6fbf521e",
  "subject_name": "django/db/models/expressions::WindowFrame.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
