# Fact e2b70973

Store id: e38c15dc-05da-4933-92c1-9d292e4dc1d6

## Text

```text
def get_col(self, alias, output_field=None)
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
- posted_at: `2026-11-09T23:44:51.6122110+00:00`

## Data

```json
{
  "end_line": 1348,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1341,
  "symbol": "ForeignKey.get_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1341,"selector":"L1341-L1348","symbol":"ForeignKey.get_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1348,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1341,
    "symbol": "ForeignKey.get_col"
  },
  "id": "e38c15dc-05da-4933-92c1-9d292e4dc1d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6122110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1341,
        "selector": "L1341-L1348",
        "symbol": "ForeignKey.get_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "1091e506-3d0c-4def-865c-864228cb4a02",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_col",
  "tags": [
    "entity:method"
  ],
  "text": "def get_col(self, alias, output_field=None)"
}
```
