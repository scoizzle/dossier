# Fact 5e0f801a

Store id: 6b44de27-656a-47f6-8693-208c5cf50465

## Text

```text
class KeyTransformIsNull(lookups.IsNull)
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
- posted_at: `2026-11-09T23:44:51.0362600+00:00`

## Data

```json
{
  "end_line": 615,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 594,
  "symbol": "KeyTransformIsNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":594,"selector":"L594-L615","symbol":"KeyTransformIsNull"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIsNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 615,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 594,
    "symbol": "KeyTransformIsNull"
  },
  "id": "6b44de27-656a-47f6-8693-208c5cf50465",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0362600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 594,
        "selector": "L594-L615",
        "symbol": "KeyTransformIsNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "4400c831-a7bb-4f65-bbd1-7a883b148233",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIsNull(lookups.IsNull)"
}
```
