# Fact 51a3aaa9

Store id: 8399a077-c468-4e7e-8d68-6483325da350

## Text

```text
def get_reverse_path_info(self, filtered_relation=None)
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
- posted_at: `2026-11-09T23:44:51.6561710+00:00`

## Data

```json
{
  "end_line": 2034,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2033,
  "symbol": "ManyToManyField.get_reverse_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2033,"selector":"L2033-L2034","symbol":"ManyToManyField.get_reverse_path_info"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.get_reverse_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2034,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2033,
    "symbol": "ManyToManyField.get_reverse_path_info"
  },
  "id": "8399a077-c468-4e7e-8d68-6483325da350",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6561710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2033,
        "selector": "L2033-L2034",
        "symbol": "ManyToManyField.get_reverse_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "d73e3dc2-f541-460b-aa38-cddf866ecca8",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_reverse_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_path_info(self, filtered_relation=None)"
}
```
