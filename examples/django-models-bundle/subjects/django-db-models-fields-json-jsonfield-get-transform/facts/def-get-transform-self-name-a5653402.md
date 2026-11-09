# Fact a5653402

Store id: 71271c0b-f2f5-46e7-b286-8913420e0bae

## Text

```text
def get_transform(self, name)
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
- posted_at: `2026-11-09T22:39:43.6169560+00:00`

## Data

```json
{
  "end_line": 126,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 122,
  "symbol": "JSONField.get_transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":122,"selector":"L122-L126","symbol":"JSONField.get_transform"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 126,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 122,
    "symbol": "JSONField.get_transform"
  },
  "id": "71271c0b-f2f5-46e7-b286-8913420e0bae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6169560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 122,
        "selector": "L122-L126",
        "symbol": "JSONField.get_transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "7616e0d8-d685-48f1-899d-15e266ac5c81",
  "subject_name": "django/db/models/fields/json::JSONField.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```
