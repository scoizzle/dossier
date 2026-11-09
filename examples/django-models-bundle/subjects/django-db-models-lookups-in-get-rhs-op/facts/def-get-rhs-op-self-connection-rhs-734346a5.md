# Fact 734346a5

Store id: fcb2648a-7602-44a4-837b-90d01e006014

## Text

```text
def get_rhs_op(self, connection, rhs)
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
- posted_at: `2026-11-09T22:39:48.1576870+00:00`

## Data

```json
{
  "end_line": 549,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 548,
  "symbol": "In.get_rhs_op"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":548,"selector":"L548-L549","symbol":"In.get_rhs_op"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.get_rhs_op](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 549,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 548,
    "symbol": "In.get_rhs_op"
  },
  "id": "fcb2648a-7602-44a4-837b-90d01e006014",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1576870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 548,
        "selector": "L548-L549",
        "symbol": "In.get_rhs_op"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "fafdb32b-9583-4ba8-940f-959662cbb7f2",
  "subject_name": "django/db/models/lookups::In.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
