# Fact 18e97dac

Store id: 0d864f24-b9e1-4e16-8fac-e0917261d279

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
- posted_at: `2026-11-09T23:31:56.0333080+00:00`

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
  "id": "0d864f24-b9e1-4e16-8fac-e0917261d279",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0333080+00:00"
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
  "subject_id": "18658061-a312-4c29-b190-7d15745431df",
  "subject_name": "django/db/models/expressions::WindowFrame.window_frame_start_end",
  "tags": [
    "entity:method"
  ],
  "text": "def window_frame_start_end(self, connection, start, end)"
}
```
