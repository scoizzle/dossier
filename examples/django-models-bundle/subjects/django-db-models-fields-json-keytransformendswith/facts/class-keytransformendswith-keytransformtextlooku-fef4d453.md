# Fact fef4d453

Store id: 100e775f-99db-49c7-8c94-d2383bc68f69

## Text

```text
class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)
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
- posted_at: `2026-11-09T23:31:58.0205480+00:00`

## Data

```json
{
  "end_line": 701,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 700,
  "symbol": "KeyTransformEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":700,"selector":"L700-L701","symbol":"KeyTransformEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 701,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 700,
    "symbol": "KeyTransformEndsWith"
  },
  "id": "100e775f-99db-49c7-8c94-d2383bc68f69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0205480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 700,
        "selector": "L700-L701",
        "symbol": "KeyTransformEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c3ea5c1b-c4eb-4f79-9f55-ef41a99a84f6",
  "subject_name": "django/db/models/fields/json::KeyTransformEndsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)"
}
```
