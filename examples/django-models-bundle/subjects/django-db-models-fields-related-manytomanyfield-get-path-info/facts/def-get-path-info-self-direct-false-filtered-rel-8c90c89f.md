# Fact 8c90c89f

Store id: 468725ba-3ded-4ba2-82ff-f19b203a7fc4

## Text

```text
def _get_path_info(self, direct=False, filtered_relation=None)
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
- posted_at: `2026-11-09T23:44:51.6490290+00:00`

## Data

```json
{
  "end_line": 2024,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1995,
  "symbol": "ManyToManyField._get_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1995,"selector":"L1995-L2024","symbol":"ManyToManyField._get_path_info"}`

## Items

```json
[
  {
    "text": "Called by both direct and indirect m2m traversal.",
    "locator": {
      "line": 1996
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._get_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2024,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1995,
    "symbol": "ManyToManyField._get_path_info"
  },
  "id": "468725ba-3ded-4ba2-82ff-f19b203a7fc4",
  "items": [
    {
      "locator": {
        "line": 1996
      },
      "text": "Called by both direct and indirect m2m traversal."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6490290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1995,
        "selector": "L1995-L2024",
        "symbol": "ManyToManyField._get_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "1bcb49e7-6110-4ea6-8435-9ad4b361d720",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_path_info(self, direct=False, filtered_relation=None)"
}
```
