# Fact fa758bcd

Store id: 2ec13a17-a4e6-414b-a7d4-c3fa1f723492

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
- posted_at: `2026-11-09T22:39:44.4731740+00:00`

## Data

```json
{
  "end_line": 2027,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2026,
  "symbol": "ManyToManyField.get_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2026,"selector":"L2026-L2027","symbol":"ManyToManyField.get_path_info"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.get_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2027,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2026,
    "symbol": "ManyToManyField.get_path_info"
  },
  "id": "2ec13a17-a4e6-414b-a7d4-c3fa1f723492",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4731740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2026,
        "selector": "L2026-L2027",
        "symbol": "ManyToManyField.get_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "4e054568-1f90-4e65-8909-5eb0d3f5a459",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
