# Fact ac49b6cd

Store id: 3ebc2a0e-bfcb-4495-ab5b-1c97a2b04b27

## Text

```text
def __init__( self, verbose_name=None, name=None, protocol="both", unpack_ipv4=False, *args, **kwargs, )
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
- posted_at: `2026-11-09T23:31:56.7329680+00:00`

## Data

```json
{
  "end_line": 2316,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2301,
  "symbol": "GenericIPAddressField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2301,"selector":"L2301-L2316","symbol":"GenericIPAddressField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2316,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2301,
    "symbol": "GenericIPAddressField.__init__"
  },
  "id": "3ebc2a0e-bfcb-4495-ab5b-1c97a2b04b27",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7329680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2301,
        "selector": "L2301-L2316",
        "symbol": "GenericIPAddressField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9f4a698c-6d78-42d2-bca4-2c7b64f5710b",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, protocol=\"both\", unpack_ipv4=False, *args, **kwargs, )"
}
```
