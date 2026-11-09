# Fact 0a5ad8a8

Store id: f79e0a2e-850c-4305-a6b6-bf096e1d7e16

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
- posted_at: `2026-11-09T22:39:44.3777480+00:00`

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
  "id": "f79e0a2e-850c-4305-a6b6-bf096e1d7e16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3777480+00:00"
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
  "subject_id": "ca9ef6d7-8a69-467f-ba23-9b0a5a0ce9ad",
  "subject_name": "django/db/models/fields/related::ForeignKey._check_on_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_on_delete(self, databases)"
}
```
