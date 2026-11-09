# Fact 18e55821

Store id: de053174-77af-4d1e-94cf-0b1be22cc30f

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
- posted_at: `2026-11-09T23:44:51.0012310+00:00`

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
  "id": "de053174-77af-4d1e-94cf-0b1be22cc30f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0012310+00:00"
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
  "subject_id": "a683b32b-9c60-4de5-a282-fd460271990e",
  "subject_name": "django/db/models/fields/json::ProcessJSONLHSMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class ProcessJSONLHSMixin"
}
```
