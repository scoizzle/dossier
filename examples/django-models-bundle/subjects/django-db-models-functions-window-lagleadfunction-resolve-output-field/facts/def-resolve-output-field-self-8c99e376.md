# Fact 8c99e376

Store id: 23a784bf-87db-4119-bbb5-3d5a9f176d7d

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
- posted_at: `2026-11-09T22:39:47.5643120+00:00`

## Data

```json
{
  "end_line": 57,
  "entity_kind": "method",
  "parent": "LagLeadFunction",
  "start_line": 55,
  "symbol": "LagLeadFunction._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":55,"selector":"L55-L57","symbol":"LagLeadFunction._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::LagLeadFunction._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 57,
    "entity_kind": "method",
    "parent": "LagLeadFunction",
    "start_line": 55,
    "symbol": "LagLeadFunction._resolve_output_field"
  },
  "id": "23a784bf-87db-4119-bbb5-3d5a9f176d7d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5643120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 55,
        "selector": "L55-L57",
        "symbol": "LagLeadFunction._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "c8fb62dd-f765-4275-b731-83dc6a1d35e0",
  "subject_name": "django/db/models/functions/window::LagLeadFunction._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
