# Fact 18e55821

Store id: 76b443bb-4d42-4494-8609-236d93a5b2fb

## Text

```text
class ProcessJSONLHSMixin
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
- posted_at: `2026-11-09T22:39:43.6848150+00:00`

## Data

```json
{
  "end_line": 400,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 357,
  "symbol": "ProcessJSONLHSMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":357,"selector":"L357-L400","symbol":"ProcessJSONLHSMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ProcessJSONLHSMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 400,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 357,
    "symbol": "ProcessJSONLHSMixin"
  },
  "id": "76b443bb-4d42-4494-8609-236d93a5b2fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6848150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 357,
        "selector": "L357-L400",
        "symbol": "ProcessJSONLHSMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7bf30e4d-2974-4a53-9ca5-a91b8f32b94e",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class ProcessJSONLHSMixin"
}
```
