# Fact 6d82a48b

Store id: 966e611e-db91-4407-8ed4-9fbc899ddc22

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
- posted_at: `2026-11-09T23:31:58.7171430+00:00`

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
  "id": "966e611e-db91-4407-8ed4-9fbc899ddc22",
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
    "posted_at": "2026-11-09T23:31:58.7171430+00:00"
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
  "subject_id": "d7c565e6-639f-4902-8b0b-f2ef3b1e548b",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
