# Fact 5b33cb37

Store id: dce0dad0-a3cb-404b-b6c9-26533ccb188e

## Text

```text
class JSONIn(ProcessJSONLHSMixin, lookups.In)
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
- posted_at: `2026-11-09T23:44:51.0098480+00:00`

## Data

```json
{
  "end_line": 483,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 403,
  "symbol": "JSONIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":403,"selector":"L403-L483","symbol":"JSONIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 483,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 403,
    "symbol": "JSONIn"
  },
  "id": "dce0dad0-a3cb-404b-b6c9-26533ccb188e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0098480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 403,
        "selector": "L403-L483",
        "symbol": "JSONIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "af23d653-bc6b-4b38-b0e0-e15d7ac8b277",
  "subject_name": "django/db/models/fields/json::JSONIn",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONIn(ProcessJSONLHSMixin, lookups.In)"
}
```
