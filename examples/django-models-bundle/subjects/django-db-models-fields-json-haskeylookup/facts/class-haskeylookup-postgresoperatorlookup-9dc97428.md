# Fact 9dc97428

Store id: 82f60278-bf6c-4278-91f6-df38bcf5f257

## Text

```text
class HasKeyLookup(PostgresOperatorLookup)
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
- posted_at: `2026-11-09T23:44:50.9596270+00:00`

## Data

```json
{
  "end_line": 265,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 183,
  "symbol": "HasKeyLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":183,"selector":"L183-L265","symbol":"HasKeyLookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 265,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 183,
    "symbol": "HasKeyLookup"
  },
  "id": "82f60278-bf6c-4278-91f6-df38bcf5f257",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9596270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 183,
        "selector": "L183-L265",
        "symbol": "HasKeyLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "cbdff0ae-c627-49d0-84f6-2d0ba2812d3f",
  "subject_name": "django/db/models/fields/json::HasKeyLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeyLookup(PostgresOperatorLookup)"
}
```
