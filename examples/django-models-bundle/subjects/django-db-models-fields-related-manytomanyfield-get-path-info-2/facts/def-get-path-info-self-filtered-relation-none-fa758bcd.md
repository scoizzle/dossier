# Fact fa758bcd

Store id: 61dd9930-9fd1-440e-a6dc-f52608ac6c90

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
- posted_at: `2026-11-09T23:31:58.8604730+00:00`

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
  "id": "61dd9930-9fd1-440e-a6dc-f52608ac6c90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8604730+00:00"
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
  "subject_id": "6603ea4b-349b-4327-be2d-89f463a49578",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
