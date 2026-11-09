# Fact e8b99d35

Store id: b4e7d4cd-c48f-49ac-9eb0-75d7b13eb31c

## Text

```text
def get_extra_restriction(self, alias, related_alias)
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
- posted_at: `2026-11-09T23:44:52.4858470+00:00`

## Data

```json
{
  "end_line": 198,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 197,
  "symbol": "ForeignObjectRel.get_extra_restriction"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":197,"selector":"L197-L198","symbol":"ForeignObjectRel.get_extra_restriction"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_extra_restriction](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 198,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 197,
    "symbol": "ForeignObjectRel.get_extra_restriction"
  },
  "id": "b4e7d4cd-c48f-49ac-9eb0-75d7b13eb31c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4858470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 197,
        "selector": "L197-L198",
        "symbol": "ForeignObjectRel.get_extra_restriction"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "d497bb7a-d785-4096-9097-8770c21fdd8f",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_extra_restriction",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_restriction(self, alias, related_alias)"
}
```
