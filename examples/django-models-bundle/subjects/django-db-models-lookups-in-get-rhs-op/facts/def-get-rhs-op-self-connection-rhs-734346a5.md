# Fact 734346a5

Store id: 0dfee849-a6ed-40cf-9b31-e0e2439a7e2c

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
- posted_at: `2026-11-09T23:32:03.3296960+00:00`

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
  "id": "0dfee849-a6ed-40cf-9b31-e0e2439a7e2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3296960+00:00"
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
  "subject_id": "deb44dfb-7ed5-4fd7-82e9-ca9dbc31eaf7",
  "subject_name": "django/db/models/lookups::In.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
