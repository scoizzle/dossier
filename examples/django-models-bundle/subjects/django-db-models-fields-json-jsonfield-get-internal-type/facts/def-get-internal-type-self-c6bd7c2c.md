# Fact c6bd7c2c

Store id: 99b1441f-9176-4ed4-a0c8-767e08f4d0de

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.9413000+00:00`

## Data

```json
{
  "end_line": 99,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 98,
  "symbol": "JSONField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L99","symbol":"JSONField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 99,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 98,
    "symbol": "JSONField.get_internal_type"
  },
  "id": "99b1441f-9176-4ed4-a0c8-767e08f4d0de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9413000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L99",
        "symbol": "JSONField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ae1a262d-34e4-48de-a91b-21d2385f6b3a",
  "subject_name": "django/db/models/fields/json::JSONField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
