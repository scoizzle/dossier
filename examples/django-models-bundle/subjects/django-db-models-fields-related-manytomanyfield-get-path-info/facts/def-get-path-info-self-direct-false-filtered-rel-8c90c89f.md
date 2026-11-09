# Fact 8c90c89f

Store id: 21011750-e098-496f-94c5-a06c90ab6ec6

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
- posted_at: `2026-11-09T22:39:44.4708410+00:00`

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
  "id": "21011750-e098-496f-94c5-a06c90ab6ec6",
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
    "posted_at": "2026-11-09T22:39:44.4708410+00:00"
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
  "subject_id": "9e7798c5-23e8-46b6-9566-1e795b5b605b",
  "subject_name": "django/db/models/fields/related::ManyToManyField._get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_path_info(self, direct=False, filtered_relation=None)"
}
```
