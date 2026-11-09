# Fact 0a5ad8a8

Store id: 4d5c2dc7-7770-4399-8e51-9bbf266dc9a2

## Text

```text
def _check_on_delete(self, databases)
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
- posted_at: `2026-11-09T23:44:51.5715480+00:00`

## Data

```json
{
  "end_line": 1168,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1081,
  "symbol": "ForeignKey._check_on_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1081,"selector":"L1081-L1168","symbol":"ForeignKey._check_on_delete"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey._check_on_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1168,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1081,
    "symbol": "ForeignKey._check_on_delete"
  },
  "id": "4d5c2dc7-7770-4399-8e51-9bbf266dc9a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5715480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1081,
        "selector": "L1081-L1168",
        "symbol": "ForeignKey._check_on_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "cc0cf3eb-df59-41f8-bc0e-12b05a75c1e9",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_on_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete(self, databases)"
}
```
