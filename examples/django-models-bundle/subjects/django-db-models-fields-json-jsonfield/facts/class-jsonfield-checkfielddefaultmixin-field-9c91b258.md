# Fact 9c91b258

Store id: 8152a4b6-7e11-4d3f-8c99-53211f625afe

## Text

```text
class JSONField(CheckFieldDefaultMixin, Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.5874210+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 24,
  "symbol": "JSONField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":24,"selector":"L24-L150","symbol":"JSONField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 24,
    "symbol": "JSONField"
  },
  "id": "8152a4b6-7e11-4d3f-8c99-53211f625afe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.5874210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 24,
        "selector": "L24-L150",
        "symbol": "JSONField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "69c26a43-d574-4b1f-91ac-eac1f5801c5f",
  "subject_name": "django/db/models/fields/json::JSONField",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONField(CheckFieldDefaultMixin, Field)"
}
```
