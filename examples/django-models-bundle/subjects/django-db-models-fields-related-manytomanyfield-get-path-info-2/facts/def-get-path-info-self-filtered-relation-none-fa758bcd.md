# Fact fa758bcd

Store id: 37b9583a-437f-4b1d-88a4-5e113e0034cd

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
- posted_at: `2026-11-09T23:44:51.6508990+00:00`

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
  "id": "37b9583a-437f-4b1d-88a4-5e113e0034cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6508990+00:00"
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
  "subject_id": "8f13dd99-3d52-4f09-b570-fe5e1a471907",
  "subject_name": "django/db/models/fields/related::ManyToManyField.get_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_path_info(self, filtered_relation=None)"
}
```
