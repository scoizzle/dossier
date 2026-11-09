# Fact e3fb3324

Store id: 4429e494-c2c7-4905-815d-0f928f5b9d99

## Text

```text
def _resolve_output_field(self)
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
- posted_at: `2026-11-09T22:39:41.7565930+00:00`

## Data

```json
{
  "end_line": 2056,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2055,
  "symbol": "Window._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2055,"selector":"L2055-L2056","symbol":"Window._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2056,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2055,
    "symbol": "Window._resolve_output_field"
  },
  "id": "4429e494-c2c7-4905-815d-0f928f5b9d99",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7565930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2055,
        "selector": "L2055-L2056",
        "symbol": "Window._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "13fda055-7a03-451a-872a-dbb684919779",
  "subject_name": "django/db/models/expressions::Window._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
