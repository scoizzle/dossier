# Fact 6d82a48b

Store id: c2924b10-46df-4463-9fa4-af8684b33f2d

## Text

```text
def get_path_info(self, filtered_relation=None)
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
- posted_at: `2026-11-09T22:39:44.3507090+00:00`

## Data

```json
{
  "end_line": 905,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 891,
  "symbol": "ForeignObject.get_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":891,"selector":"L891-L905","symbol":"ForeignObject.get_path_info"}`

## Items

```json
[
  {
    "text": "Get path from this field to the related model.",
    "locator": {
      "line": 892
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 905,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 891,
    "symbol": "ForeignObject.get_path_info"
  },
  "id": "c2924b10-46df-4463-9fa4-af8684b33f2d",
  "items": [
    {
      "locator": {
        "line": 892
      },
      "text": "Get path from this field to the related model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3507090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 891,
        "selector": "L891-L905",
        "symbol": "ForeignObject.get_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "43408e20-6193-4a68-9176-221abfc02f40",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
